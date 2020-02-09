echo off
curl -v -b cookie -X PUT -F "space_template[zip]=@C:\Users\jenny\AltspaceWorld1\template.zip" -F "space_template[game_engine_version]=20192" https://account.altvr.com/api/space_templates/1388691762184192720.json
