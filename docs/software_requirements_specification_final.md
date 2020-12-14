# Overview

The purpose of this document is to provide a detailed and ordered list of all the requirements we came up with and their desired feature location. This document outlines the specific functionality and constraints of the application, but not the implementation methods.

# Software Requirements

A list of all our features with their desired requirements starting with function then transitioning to non-functional

## Functional Requirements

### Buttons

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR1 | Buttons shall be pressable at all times | TC5, TC9 |
| FR2 | Red button shall destroy red note when pressed while overlapped| TC1 |
| FR3 | Green button shall destroy green note when pressed while overlapped| TC3 |
| FR4 | Yellow button shall destroy yellow note when pressed while overlapped| TC4 |
| FR5 | Blue button shall destroy blue note when pressed while overlapped|TC2 |

### Scoring

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR6 | The scoring system will reward the user a base amount of 100 points if they correctly time the button presses with the notes |  |
| FR7 | When the song has been beaten there shall be a victory message/screen that pops up to congratulate the user | TC8, TC19 |
| FR8 | The base score per note shall be 100 and increased by the multiplier| |
| FR9 | The multiplier shall be 2X after 8 consecutive notes are hit| TC16 |
| FR10 | The multiplier shall be 3X after 16 consecutive notes are hit| TC17 |
| FR11 | The multiplier shall be 4X after 24 consecutive notes are hit| TC18 |
| FR12 | When the rock bar hits 0 there shall be a failed message/screen | TC6 |
| FR13 | When you miss a note the rock bar shall go down by 2| TC10 |
| FR14 | When you hit a note the rock bar shall go up by 1|  |


### Scenes

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR15 | The app shall first prompt the user to choose a mode, single player or 2-player |  |
| FR16 | The app shall exit a song if the exit button is clicked |  |
| FR17 | The app shall go to a pause menu when the pause button is clicked | TC8 |
| FR18 | The app shall resume when the resume button is clicked |  |
| FR19 | The app shall go to the desired song when seleced in the song select scene | TC12, TC13, TC14, TC15 |
| FR20 | The app shall go to the song select when you select single player | TC11 |


## Non-Functional Requirements

### Scenes

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | There shall be a background song when the user is in the menus screen |  |
| NFR2 | Button UI on main menu shall allow for only single press where the user cannot tap multiple menu buttons at once |  |
| NFR3 | The app shall hold a visual list of songs to choose from |  |
| NFR4 | Songs shall have a different background to represent the lyrics or messages from the song| |
| NFR5 | Pause overlay shall darken game screen | |

### Buttons 

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR6 | The color of one button key shall be green |  |
| NFR7 | The color of one button key shall be red |  |
| NFR8 | The color of one button key shall be blue |  |
| NFR9 | The color of one button key shall be yellow |  |
| NFR10 | UI shall be active and responsive to user's inputs |  |
| NFR11 | The user shall not be able to hold down all the buttons and continue to win the game |  |


### Music

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR12 | The songs shall be a variety of difficulties |  |
| NFR13 | Songs shall have a different notes to represent the beat from the song |  |
| NFR14 | There shall be 3 songs to choose from |  |
| NFR15 | Song titles shall be present on song selection screen|  |
| NFR16 | Song image cover shall be present on song selection screen|  |
| NFR17 | Song and notes shall be synced | TC20 |


# Test Specification

Different tests applied to our project to ensure 100% success

## Unit tests

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :-----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | Red note is destroyed when overlapped and pressed with red activator | Start song, click red note activator while overlapped with red note | Touch | Red note is destroyed | Red note was destroyed | Pass | FR2 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC2 | Blue note is destroyed when overlapped and pressed with blue activator | Start song, click blue note activator while overlapped with blue note | Touch | Blue note is destroyed | Blue note was destroyed | Pass | FR5 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC3 | Green note is destroyed when overlapped and pressed with green activator | Start song, click green note activator while overlapped with green note | Touch | Green note is destroyed | Green note was destroyed | Pass | FR3 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC4 | Yellow note is destroyed when overlapped and pressed with yellow activator | Start song, click yellow note activator while overlapped with yellow note | Touch | yellow note is destroyed | yellow note was destroyed | Pass | FR4 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC5 | Buttons can be pressed at any time | Open any song, press touch buttons | Touch | Buttons can be pressed | All buttons can be pressed | Pass | FR1 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC6 | Rock metter goes below 0 | Start game, let notes pass the activators | Touch | Game will end | Game ended | Pass | FR12 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC7 | Touching the pause button | Start game, touch pause | Touch | Game will ender the pause menu | Game entered pause menu | Pass | FR17 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC8 | Winning the game | Start game, win game by finishing song | Touch | Win the game and a game win screen pops up | Won the game and game win screen pops up | Pass | FR7 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC9 | Touching outside the activator | Start song, touch anywhere other than the activator | Touch | Notes should not be destroyed | Being able to touch outside activatores does nothing to the notes | Pass | FR5 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC10 | Missing notes and miss clicking notes | Start game | Touch | Rock meter should go down | Rock meter goes down | Pass | FR13 |
  
## Integration tests
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC11 |Go into song select if you click single player in main menu | Touch single player | Touch | User should be put into song select screen | User goes into song select | Pass | FR20 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC12 | Go into Sticker brush when Sticker brush song is selected | Touch single player, Touch Sticker brush song| Touch | User should be put into sticker brush song | User goes into stickerbrush song | Pass | FR19 |
  
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC13 | Go into Wii song when Wii song is selected | Touch single player, Touch Wii song| Touch | User should be put into wii song | User goes into wii | Pass | FR19 |

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC14 | Go into Animal crossing when animal crossing song is selected | Touch single player, Touch Animal crossing song| Touch | User should be put into animal crossing song | User goes into Animal crossing song | Pass | FR19 |

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC15 | Go into Layer cake when Layer cake song is selected | Touch single player, Touch Sticker brush song| Touch | User should be put into Layer cake song | User goes into Layer cake song | Pass | FR19 |
  
  

## System tests
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC16 | Testing first level multiplier | Start song, hit 8 consequtive notes | Touch | Multiplier should go to 2X | Multiplier goes to 2X | Pass | FR9 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC17 | Testing second level multiplier | Start song, hit 16 consequtive notes | Touch | Multiplier should go to 3X | Multiplier goes to 3X | Pass | FR9 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC18 | Testing third level multiplier | Start song, hit 24 consequtive notes | Touch | Multiplier should go to 4X | Multiplier goes to 4X | Pass | FR9 |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC19 | Keeping track of notes hit correctly | Play song, win song | Touch | Win screen should show amount of notes hit | Win screen shows amount of notes hit | Pass | FR7 |
 
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC20 | Notes and music start at the same time | Start song | Touch | Notes and music should start at same time | Notes and music started at the same time | Pass | NFR17 |
  


# Software Artifacts

<Describe the purpose of this section>

* [I am a link](to_some_file.pdf)

