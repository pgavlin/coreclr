using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _pinvoke_static02_static02_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_static02_static02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\static02\\static02.cmd");
        }
    }
}
