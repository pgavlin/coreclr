using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_constructor_do_constructor_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_do_constructor_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_do\\constructor_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
