using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _RVAInit_nested_nested_
    {
        [Trait("ExcludeILLink", "{illinkExclude}")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_nested_nested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\nested\\nested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
