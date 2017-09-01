using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_sin_sin_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_sin_sin_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\sin\\sin.cmd");
        }
    }
}
