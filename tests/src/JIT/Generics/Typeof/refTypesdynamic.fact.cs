using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_refTypesdynamic_refTypesdynamic_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_refTypesdynamic_refTypesdynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\refTypesdynamic\\refTypesdynamic.cmd");
        }
    }
}
