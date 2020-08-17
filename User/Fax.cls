Class User.Fax Extends %Persistent
{

Property pic As %GlobalBinaryStream;

Property memo As %String;

Storage Default
{
<Data name="FaxDefaultData">
<Value name="1">
<Value>%%CLASSNAME</Value>
</Value>
<Value name="2">
<Value>pic</Value>
</Value>
<Value name="3">
<Value>memo</Value>
</Value>
</Data>
<DataLocation>^User.FaxD</DataLocation>
<DefaultData>FaxDefaultData</DefaultData>
<IdLocation>^User.FaxD</IdLocation>
<IndexLocation>^User.FaxI</IndexLocation>
<StreamLocation>^User.FaxS</StreamLocation>
<Type>%Storage.Persistent</Type>
}

}
