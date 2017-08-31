using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _dynamic_methods_bug_445388_bug_445388_
    {
        [OuterLoop]
        [Fact]
        public void _dynamic_methods_bug_445388_bug_445388_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\dynamic_methods\\bug_445388\\bug_445388.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
