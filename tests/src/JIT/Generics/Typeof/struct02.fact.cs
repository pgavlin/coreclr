using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_struct02_struct02_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct02_struct02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct02\\struct02.cmd");
        }
    }
}
