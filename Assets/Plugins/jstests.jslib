mergeInto(LibraryManager.library, 
{
  Hello: function (path) 
  {
    window.history.pushState({}, "", UTF8ToString(path));
  },

});