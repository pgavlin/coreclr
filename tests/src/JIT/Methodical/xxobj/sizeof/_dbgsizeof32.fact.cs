using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _xxobj_sizeof__dbgsizeof32__dbgsizeof32_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__dbgsizeof32__dbgsizeof32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_dbgsizeof32\\_dbgsizeof32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
