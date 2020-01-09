Imports Newtonsoft.Json

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quest = New Quest()

        quest.Title = "trash"
        quest.Icon = "trash_can"
        quest.displayName = "Taking out the Trash"

        Dim varDisplay = New Display With {.Type = "text", .Text = "Craft a Trash Can"}
        quest.displayItems.Add(varDisplay)

        Dim varCondition = New Condition With {.Type = "item", .Item = "trash_can", .Amount = 1}
        quest.conditionItems.Add(varCondition)

        Dim varReward = New Reward With {.Type = "item", .Item = "cobblestone", .Amount = 1}
        quest.rewardItems.Add(varReward)

        Dim rawJSON = JsonConvert.SerializeObject(quest)

        Dim output As System.IO.StreamWriter
        output = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "/trash.json", True)
        output.Write(rawJSON)
        output.Close()

    End Sub

End Class

Class Quest

    <JsonProperty(PropertyName:="name")>
    Public Property Title As String

    <JsonProperty(PropertyName:="icon")>
    Public Property Icon As String

    <JsonProperty(PropertyName:="display_name")>
    Public Property displayName As String

    <JsonProperty(PropertyName:="display")>
    Public Property displayItems As List(Of Display) = New List(Of Display)

    <JsonProperty(PropertyName:="conditions")>
    Public Property conditionItems As List(Of Condition) = New List(Of Condition)

    <JsonProperty(PropertyName:="rewards")>
    Public Property rewardItems As List(Of Reward) = New List(Of Reward)

End Class

Public Class Display

    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="text")>
    Public Property Text As String

End Class

Public Class Condition

    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="item")>
    Public Property Item As String

    <JsonProperty(PropertyName:="amount")>
    Public Property Amount As Integer

End Class

Public Class Reward

    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="item")>
    Public Property Item As String

    <JsonProperty(PropertyName:="amount")>
    Public Property Amount As Integer

End Class