using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_GenericExceptions03_GenericExceptions03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericExceptions03_GenericExceptions03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\GenericExceptions03\\GenericExceptions03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
