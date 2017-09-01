using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_dynamicTypes_dynamicTypes_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_dynamicTypes_dynamicTypes_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\dynamicTypes\\dynamicTypes.cmd");
        }
    }
}
