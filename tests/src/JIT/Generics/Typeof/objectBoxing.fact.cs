using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_objectBoxing_objectBoxing_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_objectBoxing_objectBoxing_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\objectBoxing\\objectBoxing.cmd");
        }
    }
}
