using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_TypeParameter007_TypeParameter007_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TypeParameter007_TypeParameter007_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\TypeParameter007\\TypeParameter007.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
