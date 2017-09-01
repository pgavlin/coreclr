using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_jump_jump_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_jump_jump_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\jump\\jump.cmd");
        }
    }
}
