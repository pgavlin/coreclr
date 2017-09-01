using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_struct01_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct01_struct01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct01\\struct01.cmd");
        }
    }
}
