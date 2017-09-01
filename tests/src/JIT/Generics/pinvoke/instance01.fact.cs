using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _pinvoke_instance01_instance01_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_instance01_instance01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\pinvoke\\instance01\\instance01.cmd");
        }
    }
}
