using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstboxed_d_isinstboxed_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_d_isinstboxed_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_d\\isinstboxed_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
