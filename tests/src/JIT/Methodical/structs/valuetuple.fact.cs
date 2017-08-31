using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _structs_valuetuple_valuetuple_
    {
        [OuterLoop]
        [Fact]
        public void _structs_valuetuple_valuetuple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\structs\\valuetuple\\valuetuple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
