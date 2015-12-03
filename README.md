# TSTuring-WindowsClient
### Discussion: 

http://forum.thinkingsolutions.co/forums/forum/windows-client/

### Description
A web client to access the Language Algorithm for language translation (and language learning). 
## Version

1.2.0

### Installation

Once you retrieve the Visual Studio project, and open the TSTuring2015.RRGV117windowsclienttrans.sln file, set the default project to TSTuring2015.Speech(see below), then RUN.
> In Visual Studio Specify the startup project a as TSTuring2015.Windows by:
> right click solution >> properties >> startup project >> select single startup project >> TSTuring2015.Speech

### Notes
This release has been refactored to provide translation only. Feel free to inspect or use as you like but no contributions are expected until the next server release.

The LanguageSelector.cs file specifies the allowed translations in the windows localization and GetSyllabus.cs stores the list of classes setup to run a specific syllabus. A future verion will store these files in the cloud somewhere as part of the product deployment.

## Technology
The windows client uses Microsoft's Form technology to manage the client on the Windows platform. Access to the server API is a back-end function.

To access the windows localization for speech recognition and speech sybnthesis, the appopriate Windows language preference should be installed on the computer first. The client selects the selected language from the form menu.

### Speaker form
The speaker form interacts with the translation API. The translation API accepts text and returns the target language translation. 

### Voice Syllabus directory
This directory has a user-selectable syllabus directory. Files can be stored as plain text. All selected syllabus entries can be translated in sequence using the appropriate target language settings.

This client provides access to the Thinking Solutions Language Algorithm for:

 - conversation 
 - translation 

Each of those applications uses the server API to analyze and retrieve responses.

> The design of the system is to consolidate the language content and meanings centrally for all languages. While languages continue to be built up, the APIs will continue unchanged to allow the user community to continue to operate.

### Tutorials

A number of videos demonstrate the functionality of the three applications. Developers who want to embed this into
code should use the working versions in this client code for sample of how to interact with the API.

Introduction to the translation revolution & why Google Translate is fighting a losing battle
https://www.youtube.com/watch?v=mPoE5R3q5n0

Introduction to conversation & why statistical systems are inadequate
https://www.youtube.com/watch?v=YQ2uJaeDy8s         

Comparison between new technology and Siri
https://www.youtube.com/watch?v=gxDZSKidgmY  

Very quick application of language to a simple calculator app based on English
https://www.youtube.com/watch?v=QmRbWNGcBn8  

### Background
The ‘clients’ provide exposure to the new technology which enables human-like understanding of language – potentially any language.  Currently, it has enough language loaded in English and 8 others to show samples of how it works.  A developer can see the output of our system if they download the source code and trace it.  They can see the result of the system by looking at the output on the Thinking Solutions Demo site, and the YouTube videos on Thinking Solutions channel.
 
The system produces a set of elements (roles – actor, undergoer; nucleus – adjective, noun, verb, location; attributes – positive/negative, past/present/future, aux type, voice; logical structure; etc)  that have been made available with this new multi-lingual natural language understanding (NLU).
 
The details of the system follow the Role and Reference Grammar. How Logical Structures are created is covered in the textbooks and scientific papers, but the point of the system is to remove the need for the developer to become a scientist and instead use the output of the system. That being said, as with any programming, the developer needs to be familiar with the justification for the end-to-end process.
 
Of course as sentences become more complex, the amount of embedding in the system requires the developer to pay attention to the output.

The next planned development phase for language loading (on the server) will be:
 
-Focus on English
-Load vocabulary and patterns to cover scope for connected homes and connected cars
 
This is dependent on funding and/or a suitable project.  Your feedback and interest in language applications for this software is welcome.


### Todo's

- Add Developer Feedback Loop

- Add GitHub comments regarding Thinking Solutions server projects

License

----



MIT

