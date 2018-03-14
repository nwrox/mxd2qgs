#-----------------------------------------------------------
#
# Mxd2Qgs ver 1.0
# Copyright (C) 2011 Allan Maungu
# EMAIL: lumtegis (at) gmail.com
# WEB  : http://geoscripting.blogspot.com
# Usage : Exporting current ArcMap document layers to Quantum GIS file
# The resulting file can be opened in Quantum GIS
# Tested on ArcMap 10.2, Python 2.7 and QGIS 2.0.1
#-----------------------------------------------------------
#
# licensed under the terms of GNU GPL 2
#
# This program is free software; you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation; either version 2 of the License, or
# (at your option) any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License along
# with this program; if not, write to the Free Software Foundation, Inc.,
# 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
#
#---------------------------------------------------------------------
import string
import os
import json
import arcpy

import sys

mxd = arcpy.mapping.MapDocument(sys.argv[1])
output = sys.argv[3]

# Create json
data = {}

##qgis = doc.createElement("qgis")
##qgis.setAttribute("  projectname", " ")

data['qgis'] = {
	"_projectname": "",
	"_version": "2.4.0-Chugiak",
    "title": {},
    "mapcanvas": {},
    "legend": {}
}

# fazer tipo um switch case aqui


##qgis.setAttribute("version", "1.6.0-Capiapo")
##qgis.setAttribute("version", "2.2.0-Valmiera")
##qgis.setAttribute("version", "2.4.0-Chugiak")
##doc.appendChild(qgis)

print "Converting mxd........"

df = arcpy.mapping.ListDataFrames(mxd)[0]
unit = df.mapUnits.encode("utf-8").strip()
xmin1 = df.extent.XMin
ymin1 = df.extent.YMin
xmax1 = df.extent.XMax
ymax1 = df.extent.YMax
srid1 = df.spatialReference.factoryCode
srid2 = df.spatialReference.factoryCode
epsg1 = df.spatialReference.factoryCode
epsg2 = df.spatialReference.factoryCode
description1 = df.spatialReference.name.encode("utf-8").strip()
description2 = df.spatialReference.name.encode("utf-8").strip()
ellipsoidacronym1 = df.spatialReference.name.encode("utf-8").strip()
ellipsoidacronym2 = df.spatialReference.name.encode("utf-8").strip()
geographicflag1 = 'true'
geographicflag2 = 'true'

authid2 = ('EPSG:' + `df.spatialReference.factoryCode`).encode("utf-8").strip()
authid3 = ('EPSG:' + `df.spatialReference.factoryCode`).encode("utf-8").strip()

# Layerlist elements
lyrlist = arcpy.mapping.ListLayers(df)
count1 = str(len(lyrlist))

# mapcanvas
def map_canvas():
    data['qgis']['mapcanvas'] = {
        'units': unit,
        'extent': {
            'xmin': xmin1,
            'ymin': ymin1,
            'xmax': xmax1,
            'ymax': ymax1
        },
        'projections': {},
        'destinationsrs': {
            'spatialrefsys': {
                'proj4': {},
                'srsid': {},
                'srid': srid1,
                'authid': authid2,
                'description': description1,
                'projectionacronym': {},
                'ellipsoidacronym': ellipsoidacronym1,
                'geographicflag': geographicflag1
            }
        }
    }

# Legend
def legend_func():
    for lyr in lyrlist:
        if(lyr.isGroupLayer == False):
            data['qgis']['legend'] = {
                'legendlayer': {
					'_open': 'true',
					'_checked': 'Qt::Checked',
					'_name': lyr.name.encode("utf-8").strip(),
                    'filegroup open="true" hidden="false" ': {
                        'legendlayerfile isInOverview="0" layerid="' + (lyr.name + "20110427170816078").encode("utf-8").strip() + '" visible="1" ': ""
                    }
                }
            }


# Project Layers
def project_layers():	
    data['qgis']['projectlayers'] = {
		'_layercount': count1
    }

    for lyr in lyrlist:
        if(lyr.isGroupLayer == False and lyr.isRasterLayer == False and lyr.isFeatureLayer == True):
            geometry1 = arcpy.Describe(lyr)
            geometry2 = str(geometry1.shapeType)
            ds = lyr.dataSource.encode("utf-8").strip()
			
            name1 =  (lyr.name + "20110427170816078").encode("utf-8").strip()
            name2 =  lyr.name.encode("utf-8").strip()

           # Create the <maplayer> element
            data['qgis']['projectlayers']['maplayer'] = {
				"_minimumScale": "0",
				"_maximumScale": "1e+08",
				"_minLabelScale": "0",
				"_maxLabelScale": "1e+08",
				"_geometry": geometry2,
				"_type": ("vector", "raster")[lyr.isRasterLayer],
				"_hasScaleBasedVisibilityFlag": "0",
				"_scaleBasedLabelVisibilityFlag": "0",
				"id": name1,
				"datasource": ds,
				"layername": name2,
				"srs": {
					"spatialrefsys": {
						"proj4": {},
						"srsid": {},
						"srid": srid2,
						"authid": authid3,
						"description": description2,
						"projectionacronym": {},
						"ellipsoidacronym": ellipsoidacronym2,
						"geographicflag": geographicflag2
					}
				},
				"transparencyLevelInt": 255,
				"customproperties": {},
				'provider encoding="System"': "ogr",
			}



map_canvas()
legend_func()
project_layers()

#  Write to qgis file
##    xml.dom.ext.PrettyPrint(doc, f)
##
##    -PrettyPrint(tree, out)
##    +out.write(tree.toxml())
##    f.write(doc.toprettyxml().encode("utf-8").strip())
##with open(output, "w") as f:
print json.dumps(data, indent=4)
print "Done"



