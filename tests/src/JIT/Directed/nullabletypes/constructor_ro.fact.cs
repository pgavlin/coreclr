using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_constructor_ro_constructor_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_ro_constructor_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_ro\\constructor_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
