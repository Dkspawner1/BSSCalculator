# BSSCalculator
Based on the calculations for the BSS wiki this is my passion project where I challenge myself to get out of my comfort zone and code formulas and automate information with a full JSON save file including all bees and stats  

This project consists of two main parts, the calculations and storing of each bee with their respective attributes  

[ ] Calculations Progress: 1/5 <br />
[x] Functioning JSON file which gets serialized and deserialized into my class objects.<br />

# Json Example (only common, rare and epic bees added for now)
## Example each rarity of bee and how it's stored and formated in my JSON 
```json
[
   {
      "BeeEnum":{
         "Key":1,
         "Value":"Basic"
      },
      "Rarity":0,
      "Colour":0,
      "BaseEnergy":20,
      "BaseSpeed":14,
      "BaseAttack":1,
      "BaseGather":10,
      "BaseProduction":80
   },
   {
      "BeeEnum":{
         "Key":7,
         "Value":"Looker"
      },
      "Rarity":1,
      "Colour":0,
      "BaseEnergy":20,
      "BaseSpeed":14,
      "BaseAttack":1,
      "BaseGather":13,
      "BaseProduction":160
   },
   {
      "BeeEnum":{
         "Key":11,
         "Value":"Bubble"
      },
      "Rarity":2,
      "Colour":2,
      "BaseEnergy":20,
      "BaseSpeed":16.1,
      "BaseAttack":3,
      "BaseGather":10,
      "BaseProduction":160
   }
]
```
