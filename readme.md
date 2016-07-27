#Synopsis
The objective is to find approximate string matches for short strings, in situations where a small number of differences is to be expected. The short strings could come from a dictionary, for instance. Here, one of the strings is typically short, while the other is arbitrarily long.

##Introduction

The Levenshtein distance is a string metric for measuring the difference between two sequences. Informally, the Levenshtein distance between two words is the minimum number of single-character edits (i.e. insertions, deletions or substitutions) required to change one word into the other. It is named after Vladimir Levenshtein, who considered this distance in 1965. 
Levenshtein distance may also be referred to as edit distance, although that may also denote a larger family of distance metrics. It is closely related to pairwise string alignments.

##Application
1.	String Matching (correction systems for optical character recognition).
2.	Spelling Checking.
3.	Software to assist natural language translation based on translation memory.

##Project Structure

##Installation

**Software Requirement**

1. Visual Studio

**Prerequisite**

1. Web API 2 
2. AngularJS

**Configuration**

To run project, need to setup API url in app\factoris\data-access-factory.js file

Following are the steps:
* Get API URL
* Replace API URL in javascript file

**HOW TO:**

1. Get API URL



2. Replace API URL in javascript file
```
function getMasterCommunicator() {
    var communicator = $resource("API-URL/api/home", {},
                        {
                            get: { method: "GET" },
                            query: { method: "GET", isArray: true },
                            update: { method: "POST" },
                            save: { method: "POST" },
                            remove: { method: "DELETE" }
                        });
    return communicator;
}

function getRecommendationCommunicator() {
    var communicator = $resource("API-URL/api/recommendation/:action", {},
        {
            fetch: { params: { action: "Fetch" }, method: "POST", isArray: true }
        });
    return communicator;
}
```
Replace "API-URL" with API URL (for e.g. http://localhost:54952)

#Contributing
* Nikhil Babar
* Sandeep Paithankar

#Thanks
* Vikrant Labade
