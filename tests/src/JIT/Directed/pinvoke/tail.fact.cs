using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_tail_tail_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _pinvoke_tail_tail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\tail\\tail.cmd");
        }
    }
}
