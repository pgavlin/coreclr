using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_GenericExceptions05_GenericExceptions05_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericExceptions05_GenericExceptions05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\GenericExceptions05\\GenericExceptions05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
