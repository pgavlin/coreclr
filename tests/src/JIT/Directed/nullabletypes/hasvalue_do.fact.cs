using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_hasvalue_do_hasvalue_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_do_hasvalue_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_do\\hasvalue_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
