Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace CustomWorkTimeExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#CustomWorkTime"
        Private Sub SchedulerControl_CustomWorkTime(ByVal sender As Object, ByVal e As DevExpress.Xpf.Scheduling.CustomWorkTimeEventArgs)
            If e.Resource.Id.Equals("1") Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    Dim workTimes As New List(Of TimeSpanRange)()
                    workTimes.Add(New TimeSpanRange(TimeSpan.FromHours(0), TimeSpan.FromHours(3)))
                    workTimes.Add(New TimeSpanRange(TimeSpan.FromHours(5), TimeSpan.FromHours(8)))
                    workTimes.Add(New TimeSpanRange(TimeSpan.FromHours(10), TimeSpan.FromHours(11)))
                    e.WorkTimes = workTimes
                Else
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(20))
                End If
            End If
            If e.Resource.Id.Equals("2") Then
                If e.Interval.Start.Day Mod 2 = 0 Then
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(18))
                Else
                    e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(12))
                End If
            End If
            If e.Resource.Id.Equals("3") Then
                e.WorkTime = New TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(21))
            End If
            If e.Resource.Id.Equals("4") Then
                Dim workTimes As New List(Of TimeSpanRange)()
                workTimes.Add(New TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(11)))
                workTimes.Add(New TimeSpanRange(TimeSpan.FromHours(13), TimeSpan.FromHours(17)))
                e.WorkTimes = workTimes
            End If
        End Sub
        #End Region ' #CustomWorkTime
    End Class
End Namespace
