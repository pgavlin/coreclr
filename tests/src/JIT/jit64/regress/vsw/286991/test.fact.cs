using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_286991_test_test_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _regress_vsw_286991_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\286991\\test\\test.cmd");
        }
    }
}
