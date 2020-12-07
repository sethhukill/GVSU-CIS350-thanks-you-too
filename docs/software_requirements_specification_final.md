# Overview

The purpose of this document is to provide a detailed and ordered list of all the requirements we came up with and their desired feature location. This document outlines the specific functionality and constraints of the application, but not the implementation methods.

# Software Requirements

<Describe the structure of this section>

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
| FR15 | The app shall first prompt the user to choose a mode, single player or 2-player | TC1 |
| FR16 | The app shall exit a song if the exit button is clicked | TC2 |
| FR17 | The app shall go to a pause menu when the pause button is clicked | TC1,TC2 |
| FR18 | The app shall resume when the resume button is clicked | TC1,TC2 |
| FR19 | The app shall go to the desired song when seleced in the song select scene | TC1,TC2 |


## Non-Functional Requirements

### Scenes

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | <Non-Functional Requirement 1> | TC4 |
| NFR2 | < Non-Functional Requirement 2> | TBD |
| NFR3 | < Non-Functional Requirement 3> | TC6 |
| … | … | … |
### Buttons 

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | The color of the button keys shall be red, blue, yellow, and green | TC4 |
| NFR2 | < Non-Functional Requirement 2> | TBD |
| NFR3 | < Non-Functional Requirement 3> | TC6 |
| … | … | … |

### Music

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | <Non-Functional Requirement 1> | TC4 |
| NFR2 | < Non-Functional Requirement 2> | TBD |
| NFR3 | < Non-Functional Requirement 3> | TC6 |
| … | … | … |

### <Name of Feature 4> 

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | <Non-Functional Requirement 1> | TC4 |
| NFR2 | < Non-Functional Requirement 2> | TBD |
| NFR3 | < Non-Functional Requirement 3> | TC6 |
| … | … | … |

### <Name of Feature 5> 

| ID  | Requirement     | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | <Non-Functional Requirement 1> | TC4 |
| NFR2 | < Non-Functional Requirement 2> | TBD |
| NFR3 | < Non-Functional Requirement 3> | TC6 |
| … | … | … |

# Test Specification

<Description of what this section is>

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
  
  
(copy/paste the above table a minimum of 5 times)

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
  
(copy/paste the above table a minimum of 5 times)

# Software Artifacts

<Describe the purpose of this section>

* [I am a link](to_some_file.pdf)

