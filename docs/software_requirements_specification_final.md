# Overview

The purpose of this document is to provide a detailed and ordered list of all the requirements we came up with and their desired feature location. This document outlines the specific functionality and constraints of the application, but not the implementation methods.

# Software Requirements

A list of all our features with their desired requirements starting with function then transitioning to non-functional

## Functional Requirements

### Buttons

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR1 | Buttons shall be pressable at all times ||
| FR2 | Red button shall destroy red note when pressed while overlapped| |
| FR3 | Green button shall destroy green note when pressed while overlapped| |
| FR4 | Yellow button shall destroy yellow note when pressed while overlapped| |
| FR5 | Blue button shall destroy blue note when pressed while overlapped| |

### Scoring

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR6 | The scoring system will reward the user a base amount of 100 points if they correctly time the button presses with the notes |  |
| FR7 | When the song has been beaten there shall be a victory message/screen that pops up to congratulate the user | |
| FR8 | The base score per note shall be 100 and increased by the multiplier| |
| FR9 | The multiplier shall be 2X after 8 consecutive notes are hit|  |
| FR10 | The multiplier shall be 3X after 16 consecutive notes are hit|  |
| FR11 | The multiplier shall be 4X after 24 consecutive notes are hit|  |
| FR12 | When the rock bar hits 0 there shall be a failed message/screen |  |
| FR13 | When you miss a note the rock bar shall go down by 2|  |
| FR14 | When you hit a note the rock bar shall go up by 1|  |


### Scenes

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| FR15 | The app shall first prompt the user to choose a mode, single player or 2-player |  |
| FR16 | The app shall exit a song if the exit button is clicked |  |
| FR17 | The app shall go to a pause menu when the pause button is clicked |  |
| FR18 | The app shall resume when the resume button is clicked |  |
| FR19 | The app shall go to the desired song when seleced in the song select scene |  |


## Non-Functional Requirements

### Scenes

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | There shall be a background song when the user is in the menus screen | TC4 |
| NFR2 | Button UI on main menu shall allow for only single press where the user cannot tap multiple menu buttons at once | TBD |
| NFR3 | The app shall hold a visual list of songs to choose from | TC6 |
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

# Test Specification

Different tests applied to our project to ensure 100% success

## Unit tests

| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
## Integration tests
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  

## System tests
| ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  
  | ID  | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | <TC1 description> | <steps to execute TC1> | <input values to this test case> | <expected output as a result of test case> | <actual output of test case> | <did it pass or fail?> | <requirement IDs this test case is linked to> |
  


# Software Artifacts

<Describe the purpose of this section>

* [I am a link](to_some_file.pdf)

