using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_TypeParameter015_TypeParameter015_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TypeParameter015_TypeParameter015_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\TypeParameter015\\TypeParameter015.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
