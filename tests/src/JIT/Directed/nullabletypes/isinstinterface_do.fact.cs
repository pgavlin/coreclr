using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstinterface_do_isinstinterface_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_do_isinstinterface_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_do\\isinstinterface_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
