using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hasvalue_ro_hasvalue_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_ro_hasvalue_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_ro\\hasvalue_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
