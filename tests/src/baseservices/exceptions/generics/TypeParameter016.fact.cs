using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_TypeParameter016_TypeParameter016_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TypeParameter016_TypeParameter016_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\TypeParameter016\\TypeParameter016.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
