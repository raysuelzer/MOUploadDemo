
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://mushroomobserver.org/response.xsd", IsNullable = false)]
public partial class response
{

    private responseVersion versionField;

    private responseRun_date run_dateField;

    private responseQuery queryField;

    private responseNumber_of_records number_of_recordsField;

    private responseNumber_of_pages number_of_pagesField;

    private responsePage_number page_numberField;

    private responseResults resultsField;

    private responseRun_time run_timeField;

    /// <remarks/>
    public responseVersion version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    public responseRun_date run_date
    {
        get
        {
            return this.run_dateField;
        }
        set
        {
            this.run_dateField = value;
        }
    }

    /// <remarks/>
    public responseQuery query
    {
        get
        {
            return this.queryField;
        }
        set
        {
            this.queryField = value;
        }
    }

    /// <remarks/>
    public responseNumber_of_records number_of_records
    {
        get
        {
            return this.number_of_recordsField;
        }
        set
        {
            this.number_of_recordsField = value;
        }
    }

    /// <remarks/>
    public responseNumber_of_pages number_of_pages
    {
        get
        {
            return this.number_of_pagesField;
        }
        set
        {
            this.number_of_pagesField = value;
        }
    }

    /// <remarks/>
    public responsePage_number page_number
    {
        get
        {
            return this.page_numberField;
        }
        set
        {
            this.page_numberField = value;
        }
    }

    /// <remarks/>
    public responseResults results
    {
        get
        {
            return this.resultsField;
        }
        set
        {
            this.resultsField = value;
        }
    }

    /// <remarks/>
    public responseRun_time run_time
    {
        get
        {
            return this.run_timeField;
        }
        set
        {
            this.run_timeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseVersion
{

    private string typeField;

    private string content_typeField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseRun_date
{

    private string typeField;

    private string formatField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseQuery
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseNumber_of_records
{

    private string typeField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseNumber_of_pages
{

    private string typeField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responsePage_number
{

    private string typeField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResults
{

    private responseResultsResult[] resultField;

    private int numberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("result")]
    public responseResultsResult[] result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResult
{

    private responseResultsResultOwner ownerField;

    private responseResultsResultDate dateField;

    private responseResultsResultLocation locationField;

    private responseResultsResultSpecimen_available specimen_availableField;

    private responseResultsResultIs_collection_location is_collection_locationField;

    private responseResultsResultConsensus_name consensus_nameField;

    private responseResultsResultConfidence confidenceField;

    private responseResultsResultNotes notesField;

    private responseResultsResultCreated_at created_atField;

    private responseResultsResultUpdated_at updated_atField;

    private responseResultsResultNumber_of_views number_of_viewsField;

    private responseResultsResultLast_viewed last_viewedField;

    private responseResultsResultNamings namingsField;

    private responseResultsResultPrimary_image primary_imageField;

    private responseResultsResultImages imagesField;

    private responseResultsResultComments commentsField;

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultOwner owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultDate date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultSpecimen_available specimen_available
    {
        get
        {
            return this.specimen_availableField;
        }
        set
        {
            this.specimen_availableField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultIs_collection_location is_collection_location
    {
        get
        {
            return this.is_collection_locationField;
        }
        set
        {
            this.is_collection_locationField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultConsensus_name consensus_name
    {
        get
        {
            return this.consensus_nameField;
        }
        set
        {
            this.consensus_nameField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultConfidence confidence
    {
        get
        {
            return this.confidenceField;
        }
        set
        {
            this.confidenceField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNotes notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultCreated_at created_at
    {
        get
        {
            return this.created_atField;
        }
        set
        {
            this.created_atField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultUpdated_at updated_at
    {
        get
        {
            return this.updated_atField;
        }
        set
        {
            this.updated_atField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNumber_of_views number_of_views
    {
        get
        {
            return this.number_of_viewsField;
        }
        set
        {
            this.number_of_viewsField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLast_viewed last_viewed
    {
        get
        {
            return this.last_viewedField;
        }
        set
        {
            this.last_viewedField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNamings namings
    {
        get
        {
            return this.namingsField;
        }
        set
        {
            this.namingsField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultPrimary_image primary_image
    {
        get
        {
            return this.primary_imageField;
        }
        set
        {
            this.primary_imageField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultImages images
    {
        get
        {
            return this.imagesField;
        }
        set
        {
            this.imagesField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultComments comments
    {
        get
        {
            return this.commentsField;
        }
        set
        {
            this.commentsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultOwner
{

    private responseResultsResultOwnerLogin_name login_nameField;

    private responseResultsResultOwnerLegal_name legal_nameField;

    private ushort idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultOwnerLogin_name login_name
    {
        get
        {
            return this.login_nameField;
        }
        set
        {
            this.login_nameField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultOwnerLegal_name legal_name
    {
        get
        {
            return this.legal_nameField;
        }
        set
        {
            this.legal_nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultOwnerLogin_name
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultOwnerLegal_name
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultDate
{

    private string typeField;

    private string formatField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocation
{

    private responseResultsResultLocationName nameField;

    private responseResultsResultLocationLatitude_north latitude_northField;

    private responseResultsResultLocationLatitude_south latitude_southField;

    private responseResultsResultLocationLongitude_east longitude_eastField;

    private responseResultsResultLocationLongitude_west longitude_westField;

    private responseResultsResultLocationAltitude altitudeField;

    private responseResultsResultLocationAltitude_maximum altitude_maximumField;

    private responseResultsResultLocationAltitude_minimum altitude_minimumField;

    private ushort idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultLocationName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    

    /// <remarks/>
    public responseResultsResultLocationLatitude_north latitude_north
    {
        get
        {
            return this.latitude_northField;
        }
        set
        {
            this.latitude_northField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationLatitude_south latitude_south
    {
        get
        {
            return this.latitude_southField;
        }
        set
        {
            this.latitude_southField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationLongitude_east longitude_east
    {
        get
        {
            return this.longitude_eastField;
        }
        set
        {
            this.longitude_eastField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationLongitude_west longitude_west
    {
        get
        {
            return this.longitude_westField;
        }
        set
        {
            this.longitude_westField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationAltitude altitude
    {
        get
        {
            return this.altitudeField;
        }
        set
        {
            this.altitudeField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationAltitude_maximum altitude_maximum
    {
        get
        {
            return this.altitude_maximumField;
        }
        set
        {
            this.altitude_maximumField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultLocationAltitude_minimum altitude_minimum
    {
        get
        {
            return this.altitude_minimumField;
        }
        set
        {
            this.altitude_minimumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationName
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationLatitude
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationLatitude_north
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationLatitude_south
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationLongitude_east
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationLongitude_west
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationAltitude
{

    private string typeField;

    private string unitsField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationAltitude_maximum
{

    private string typeField;

    private string unitsField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLocationAltitude_minimum
{

    private string typeField;

    private string unitsField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultSpecimen_available
{

    private string typeField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultIs_collection_location
{

    private string typeField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultConsensus_name
{

    private responseResultsResultConsensus_nameName nameField;

    private responseResultsResultConsensus_nameAuthor authorField;

    private responseResultsResultConsensus_nameRank rankField;

    private ushort idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultConsensus_nameName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultConsensus_nameAuthor author
    {
        get
        {
            return this.authorField;
        }
        set
        {
            this.authorField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultConsensus_nameRank rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultConsensus_nameName
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultConsensus_nameAuthor
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultConsensus_nameRank
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultConfidence
{

    private string typeField;

    private string rangeField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNotes
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCreated_at
{

    private string typeField;

    private string formatField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultUpdated_at
{

    private string typeField;

    private string formatField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNumber_of_views
{

    private string typeField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultLast_viewed
{

    private string typeField;

    private string formatField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamings
{

    private responseResultsResultNamingsNaming[] namingField;

    private int numberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("naming")]
    public responseResultsResultNamingsNaming[] naming
    {
        get
        {
            return this.namingField;
        }
        set
        {
            this.namingField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNaming
{

    private responseResultsResultNamingsNamingName nameField;

    private responseResultsResultNamingsNamingConfidence confidenceField;

    private responseResultsResultNamingsNamingReasons reasonsField;

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultNamingsNamingName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNamingsNamingConfidence confidence
    {
        get
        {
            return this.confidenceField;
        }
        set
        {
            this.confidenceField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNamingsNamingReasons reasons
    {
        get
        {
            return this.reasonsField;
        }
        set
        {
            this.reasonsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingName
{

    private responseResultsResultNamingsNamingNameName nameField;

    private responseResultsResultNamingsNamingNameAuthor authorField;

    private responseResultsResultNamingsNamingNameRank rankField;

    private ushort idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultNamingsNamingNameName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNamingsNamingNameAuthor author
    {
        get
        {
            return this.authorField;
        }
        set
        {
            this.authorField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultNamingsNamingNameRank rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingNameName
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingNameAuthor
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingNameRank
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingConfidence
{

    private string typeField;

    private string rangeField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingReasons
{

    private responseResultsResultNamingsNamingReasonsReason[] reasonField;

    private int numberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("reason")]
    public responseResultsResultNamingsNamingReasonsReason[] reason
    {
        get
        {
            return this.reasonField;
        }
        set
        {
            this.reasonField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultNamingsNamingReasonsReason
{

    private string categoryField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_image
{

    private responseResultsResultPrimary_imageDate dateField;

    private responseResultsResultPrimary_imageCopyright_holder copyright_holderField;

    private responseResultsResultPrimary_imageLicense licenseField;

    private responseResultsResultPrimary_imageQuality qualityField;

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultPrimary_imageDate date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultPrimary_imageCopyright_holder copyright_holder
    {
        get
        {
            return this.copyright_holderField;
        }
        set
        {
            this.copyright_holderField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultPrimary_imageLicense license
    {
        get
        {
            return this.licenseField;
        }
        set
        {
            this.licenseField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultPrimary_imageQuality quality
    {
        get
        {
            return this.qualityField;
        }
        set
        {
            this.qualityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_imageDate
{

    private string typeField;

    private string formatField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_imageCopyright_holder
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_imageLicense
{

    private responseResultsResultPrimary_imageLicenseName nameField;

    private int idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultPrimary_imageLicenseName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_imageLicenseName
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultPrimary_imageQuality
{

    private string typeField;

    private string rangeField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImages
{

    private responseResultsResultImagesImage[] imageField;

    private int numberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("image")]
    public responseResultsResultImagesImage[] image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImage
{

    private responseResultsResultImagesImageDate dateField;

    private responseResultsResultImagesImageCopyright_holder copyright_holderField;

    private responseResultsResultImagesImageLicense licenseField;

    private responseResultsResultImagesImageQuality qualityField;

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultImagesImageDate date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultImagesImageCopyright_holder copyright_holder
    {
        get
        {
            return this.copyright_holderField;
        }
        set
        {
            this.copyright_holderField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultImagesImageLicense license
    {
        get
        {
            return this.licenseField;
        }
        set
        {
            this.licenseField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultImagesImageQuality quality
    {
        get
        {
            return this.qualityField;
        }
        set
        {
            this.qualityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImageDate
{

    private string typeField;

    private string formatField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string format
    {
        get
        {
            return this.formatField;
        }
        set
        {
            this.formatField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImageCopyright_holder
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImageLicense
{

    private responseResultsResultImagesImageLicenseName nameField;

    private int idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultImagesImageLicenseName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImageLicenseName
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultImagesImageQuality
{

    private string typeField;

    private string rangeField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultComments
{

    private responseResultsResultCommentsComment[] commentField;

    private int numberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("comment")]
    public responseResultsResultCommentsComment[] comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCommentsComment
{

    private responseResultsResultCommentsCommentSummary summaryField;

    private responseResultsResultCommentsCommentContent contentField;

    private responseResultsResultCommentsCommentOwner ownerField;

    private responseResultsResultCommentsCommentObject objectField;

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    public responseResultsResultCommentsCommentSummary summary
    {
        get
        {
            return this.summaryField;
        }
        set
        {
            this.summaryField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultCommentsCommentContent content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultCommentsCommentOwner owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }

    /// <remarks/>
    public responseResultsResultCommentsCommentObject @object
    {
        get
        {
            return this.objectField;
        }
        set
        {
            this.objectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCommentsCommentSummary
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCommentsCommentContent
{

    private string typeField;

    private string content_typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string content_type
    {
        get
        {
            return this.content_typeField;
        }
        set
        {
            this.content_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCommentsCommentOwner
{

    private ushort idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseResultsResultCommentsCommentObject
{

    private uint idField;

    private string urlField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://mushroomobserver.org/response.xsd")]
public partial class responseRun_time
{

    private string typeField;

    private string unitsField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

