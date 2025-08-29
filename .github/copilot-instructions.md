# GitHub Copilot Instructions for RimWorld Modding Project: Watergazing Spot

## Mod Overview and Purpose

**Mod Name:** Watergazing Spot

The Watergazing Spot mod introduces a new joy activity to RimWorld where pawns can engage in a meditative joy activity by gazing at water. This mod allows for relaxing gameplay while pawns appreciate water-based environments, enjoying a calming effect similar to stargazing or watching a sunset. Although this feature was available in the mod "Advanced Bridges Continued," this standalone version is designed for compatibility with vanilla RimWorld or when used alongside any bridge-mods, ensuring broader accessibility.

## Key Features and Systems

- **Watergazing Spot**: A new building that pawns can use for a meditative joy activity.
- **Improved Placement**: The spot can be placed intuitively, and pawns can look at impassible water types.
- **Safety Measures**: The Watergazing Spot is designed such that it will not be targeted by raiders or disturb dormant mechanoids.

## Coding Patterns and Conventions

- **Naming Conventions**: 
  - Classes use PascalCase (e.g., `JobDriver_WaterGazing`, `PlaceWorker_WatergazingSpot`).
  - Methods and local variables use camelCase.
- **Class Declarations**: Each class begins with a public access modifier for simplicity and uniform access.
- **Inheritance**:
  - `JobDriver_WaterGazing` inherits from `JobDriver_WatchBuilding`.
  - `PlaceWorker_WatergazingSpot` inherits from `PlaceWorker`.
  - `WatergazingSpot` inherits from `Building`.
  
## XML Integration

- **XML Definitions**: XML files define the objects and their interactions in RimWorld. Ensure all building definitions correspond accurately to those in code.
- **Mod Structure**: Ensure all XML files are correctly structured in the mod folder under `Defs`. Use key/value pairs for properties like `defName`, `label`, `description`, and other building attributes.

## Harmony Patching

- **Harmony Usage**: Use the Harmony library to patch existing game methods if necessary. This mod could modify pawn behavior to initiate the joy activity or customize interaction with water types.
- **Patch Location**: Ensure Harmony patches are placed in a directory like `Patches` to maintain organization.

## Suggestions for Copilot

- **Job Implementation**: Use Copilot to help generate the job logic to ensure that pawns gather correctly at the Watergazing Spot and have the trigger to gain joy.
- **Placement Logic**: Utilize Copilot to refine placement logic in `PlaceWorker_WatergazingSpot.cs` to ensure intuitive placement.
- **UI Enhancements**: Consider suggestions from Copilot for enhancing the mod's UI elements (e.g., tooltips for the Watergazing Spot).
- **Harmony Integration**: Let Copilot help set up and organize any necessary Harmony patches, ensuring smooth integration with the base game code.

By following these instructions, Copilot can aid in maintaining consistency and efficiency in the development of the Watergazing Spot mod, enhancing both the developer experience and the end-user experience in RimWorld.
