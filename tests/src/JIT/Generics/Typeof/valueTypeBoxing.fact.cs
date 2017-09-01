using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_valueTypeBoxing_valueTypeBoxing_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_valueTypeBoxing_valueTypeBoxing_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\valueTypeBoxing\\valueTypeBoxing.cmd");
        }
    }
}
