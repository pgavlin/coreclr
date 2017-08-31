using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstboxed_ro_isinstboxed_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_ro_isinstboxed_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_ro\\isinstboxed_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
