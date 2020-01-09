Imports Newtonsoft.Json
Imports System.Json

Public Class Form1

    Dim quest = New Quest()

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        quest.Title = txtName.Text.ToLower()
        quest.Icon = txtIcon.Text
        quest.displayName = txtDisplayName.Text

        Dim varDisplay = New Display With {.Type = "text", .Text = txtDisplayText.Text}
        quest.displayItems.Add(varDisplay)

        If txtDisplayRecipe.Text <> "" Then
            Dim varDisplayRecipe = New Display With {.Type = "recipe", .Query = txtDisplayRecipe.Text}
            quest.displayItems.Add(varDisplayRecipe)
        End If

        If txtConditionItem.Text <> "" Then
            Dim varCondition = New Condition With {.Type = "item", .Item = txtConditionItem.Text, .Amount = Val(txtConditionAmount.Text)}
            quest.conditionItems.Add(varCondition)
        End If

        If txtRewardItem.Text <> "" Then
            Dim varReward = New Reward With {.Type = "item", .Item = txtRewardItem.Text, .Amount = Val(txtRewardAmount.Text)}
            quest.rewardItems.Add(varReward)
        End If

        Dim rawJSON = JsonConvert.SerializeObject(quest, Newtonsoft.Json.Formatting.Indented)

        Dim output As System.IO.StreamWriter
        output = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Jones\Desktop\Quests" & "/" & txtName.Text & ".json", True)
        output.Write(rawJSON)
        output.Close()

        txtName.Text = ""
        txtIcon.Text = ""
        txtDisplayName.Text = ""
        txtDisplayText.Text = ""
        txtDisplayRecipe.Text = ""
        txtConditionItem.Text = ""
        txtConditionAmount.Text = ""
        txtRewardItem.Text = ""
        txtRewardAmount.Text = ""

        Redirect.Show()
        Me.Close()
    End Sub

    Private Sub btnConditions_Click(sender As Object, e As EventArgs) Handles btnConditions.Click

        Dim varCondition = New Condition With {.Type = "item", .Item = txtConditionItem.Text, .Amount = Val(txtConditionAmount.Text)}
        quest.conditionItems.Add(varCondition)

        txtConditionAmount.Text = ""
        txtConditionItem.Text = ""
    End Sub

    Private Sub btnRewards_Click(sender As Object, e As EventArgs) Handles btnRewards.Click

        Dim varReward = New Reward With {.Type = "item", .Item = txtRewardItem.Text, .Amount = Val(txtRewardAmount.Text)}
        quest.rewardItems.Add(varReward)

        txtRewardItem.Text = ""
        txtRewardAmount.Text = ""
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

    <JsonProperty(PropertyName:="text", NullValueHandling:=NullValueHandling.Ignore)>
    Public Property Text As String

    <JsonProperty(PropertyName:="query", NullValueHandling:=NullValueHandling.Ignore)>
    Public Property Query As String

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