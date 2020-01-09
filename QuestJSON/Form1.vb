Imports Newtonsoft.Json
Imports System.Linq

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quest = New Quest()

        quest.Title = "trash"
        quest.Icon = "trash_can"
        quest.displayName = "Taking out the Trash"

        Dim varDisplay = New Display()
        varDisplay.Type = "item"
        varDisplay.Text = "Craft a Trash Can"
        quest.display.displayItems.Add(varDisplay)

        Dim varCondition = New Condition()
        varCondition.Type = "item"
        varCondition.Item = "trash_can"
        quest.conditions.conditionItems.Add(varCondition)

        Dim varReward = New Reward()
        varReward.Type = "item"
        varReward.Item = "cobblestone"
        varReward.Amount = 1
        quest.rewards.rewardItems.Add(varReward)

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
    Public Property display As DisplayItems = New DisplayItems

    <JsonProperty(PropertyName:="conditions")>
    Public Property conditions As ConditionItems = New ConditionItems

    <JsonProperty(PropertyName:="rewards")>
    Public Property rewards As RewardItems = New RewardItems
End Class

Public Class Display
    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="text")>
    Public Property Text As String
End Class

Public Class DisplayItems
    <JsonProperty(PropertyName:="display")>
    Public Property displayItems As List(Of Display) = New List(Of Display)
End Class

Public Class Condition
    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="item")>
    Public Property Item As String

    <JsonProperty(PropertyName:="amount")>
    Public Property Amount As Integer
End Class

Public Class ConditionItems
    <JsonProperty(PropertyName:="conditions")>
    Public Property conditionItems As List(Of Condition) = New List(Of Condition)
End Class

Public Class Reward
    <JsonProperty(PropertyName:="type")>
    Public Property Type As String

    <JsonProperty(PropertyName:="item")>
    Public Property Item As String

    <JsonProperty(PropertyName:="amount")>
    Public Property Amount As Integer
End Class

Public Class RewardItems
    <JsonProperty(PropertyName:="rewards")>
    Public Property rewardItems As List(Of Reward) = New List(Of Reward)
End Class
