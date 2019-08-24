# notes-boilerplate 
 Cross-platform Android, iOS, UWP native mobile tabbed-paged **boilerplate note-taking application**. Page view partial classes have been re-written in C# - i.e. no XAML. The project is modelled on the default Xamarin.Forms tabbed-page solution. The pure C# implementation has tried to stay within the bounds of the MVVM pattern.
 
 The user can add and view notes. Notes are saved to the device's local storage.

<img src="/PreviewImages/ItemsPageView.png" alt="The main page view" align="left" width="410">
<img src="/PreviewImages/NewItemPageView.png" alt="Adding a new item" align="right" width="410">

## Contents
 - [**Dependencies**](https://github.com/neetfreek/notes-boilerplate#dependencies)
 - [**Acknowledgements**](https://github.com/neetfreek/notes-boilerplate#acknowledgements)
 - [**Overview**](https://github.com/neetfreek/notes-boilerplate#overview)

## Dependencies

### .NET Standard
 .NET Standard library APIs are available on all .NET implementations and makes code-sharing easier across different platforms. See the [Xamarin documentation](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/internals/net-standard) for more.

### Xamarin.Forms
 Cross-platform UI toolkit for .NET development written in C#. See the [Xamarin documentation](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/) for more.

### PCLStorage
 Provides cross-platform IO APIs. See the [PCLStorage repo](https://github.com/dsplaisted/PCLStorage) for more.


## Overview

### MainPage View
The tabbed-paged. Other pages are added as children to this page.

### AboutPage View
Basic boilerplate information about the application, childed to the MainPage. Navigated to by pressing the About icon on the toolbar.

### ItemsPage View
Overview of any notes the user has taken. Displays notes within a vertical scrollable scroll-view. Navigated to by pressing the Home icon on the toolbar.

### NewItemPage View
Allows user to input new note's Name and Description using Entry and Editor controls respectively. Items saved to device's local storage by clicking the Save button on the toolbar. Navigated to by pressing the Plus icon on the toolbar.

### ItemDetailPage View
Displays the note's Name and Description.

## Acknowledgements

### Icons
 feathericons (https://github.com/feathericons/feather) by Cole Bemis, released under the MIT License.