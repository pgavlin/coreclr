using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_GenericExceptions08_GenericExceptions08_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericExceptions08_GenericExceptions08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\GenericExceptions08\\GenericExceptions08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
