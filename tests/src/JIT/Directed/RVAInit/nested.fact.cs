using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _RVAInit_nested_nested_
    {
        [Trait("ExcludeILLink", "{illinkExclude}")]
        [OuterLoop]
        [Fact]
        public void _RVAInit_nested_nested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\RVAInit\\nested\\nested.cmd");
        }
    }
}
