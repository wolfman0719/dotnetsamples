Class REST.JSON Extends %Base
{

ClassMethod GetColorsDirect() As %Status
{
	
    set tS=$$$OK
    
    try {
	         write "[",!
	         write "    [""red"", ""赤""],",!
	         write "    [""blue"", ""青""],",!
	         write "    [""yellow"", ""黄""],",!
	         write "]",!
    } catch ex {
        set tS=ex.AsStatus()
    }
    quit tS
}

ClassMethod GetColors() As %Status
{
	
    set tS=$$$OK
    
    try {
	       set colors = {}
	       set colors.red = "赤"
	       set colors.blue = "青"
	       set colors.yellow = "黄"
	       do colors.%ToJSON()
    } catch ex {
        set tS=ex.AsStatus()
    }
    
    quit tS
}

ClassMethod SendJSON(pJsontext As %String) As %Status
{
    set tS = $$$OK

    kill ^json
                    
    try 
    {
    
       set dobj = {}.%FromJSON(pJsontext)
	    
	   set ^json("Grade") = dobj.Grade
	   set ^json("Class") = dobj.Class
	   set ^json("Name") = dobj.Name
	  
	  set iter = dobj.Results.%GetIterator()
	  While iter.%GetNext(.key,.value) {
		  set ^json("Results",key+1,"Subject") = value.Subject
		  set ^json("Results",key+1,"Score") = value.Score
	  }
	  
    }
    catch ex {
	    set tS=ex.AsStatus()
    }
 Quit tS
}

}
