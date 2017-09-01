using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _pinvoke_instance02_instance02_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_instance02_instance02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\instance02\\instance02.cmd");
        }
    }
}
