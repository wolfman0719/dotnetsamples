Class MyApp.Person2 Extends (%Persistent, %Populate, %XML.Adaptor)
{

/// 名前
Property Name As %String;

Property DOB As %Date(FORMAT = 3);

Property FavoriteColors As list Of %String;

Property Picture As %Stream.FileBinary(LOCATION = "c:\temp");

Storage Default
{
<Data name="Doctors">
<Attribute>Doctors</Attribute>
<Structure>subnode</Structure>
<Subscript>"Doctors"</Subscript>
</Data>
<Data name="Person2DefaultData">
<Value name="1">
<Value>%%CLASSNAME</Value>
</Value>
<Value name="2">
<Value>Name</Value>
</Value>
<Value name="3">
<Value>DOB</Value>
</Value>
<Value name="4">
<Value>Spouse</Value>
</Value>
<Value name="5">
<Value>FavoriteColors</Value>
</Value>
<Value name="6">
<Value>Picture</Value>
</Value>
</Data>
<DataLocation>^MyApp.Person2D</DataLocation>
<DefaultData>Person2DefaultData</DefaultData>
<IdLocation>^MyApp.Person2D</IdLocation>
<IndexLocation>^MyApp.Person2I</IndexLocation>
<StreamLocation>^MyApp.Person2S</StreamLocation>
<Type>%Storage.Persistent</Type>
}

}
