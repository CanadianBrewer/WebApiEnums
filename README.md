I believe that this meets Kallol's need of not passing magic numbers, but instead passing strings.
The passed in strings evaluate to Enums correctly inside the code.

Here is what is generated in the swagger.json file. 

{
	"components": {
		"schemas": {
			"Family": {
				"enum": [
					"Rick",
					"Christine",
					"Ian",
					"William"
				],
				"type": "string"
			},
			"FamilyRequest": {
				"type": "object",
				"properties": {
					"id": {
						"type": "integer",
						"format": "int32"
					},
					"familyMember": {
						"$ref": "#/components/schemas/Family"
					},
					"pet": {
						"$ref": "#/components/schemas/Pets"
					}
				},
				"additionalProperties": false
			},
			"Pets": {
				"enum": [
					"Grommit",
					"Kepler",
					"Grover"
				],
				"type": "string"
			}
		}
	}
}