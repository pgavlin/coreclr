using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstboxed_r_isinstboxed_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_r_isinstboxed_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_r\\isinstboxed_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
