using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstboxed_do_isinstboxed_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstboxed_do_isinstboxed_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstboxed_do\\isinstboxed_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
