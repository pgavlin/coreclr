using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_GenericExceptions_GenericExceptions_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericExceptions_GenericExceptions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\GenericExceptions\\GenericExceptions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
