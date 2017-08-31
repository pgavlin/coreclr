using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_TypeParameter002_TypeParameter002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TypeParameter002_TypeParameter002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\TypeParameter002\\TypeParameter002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
