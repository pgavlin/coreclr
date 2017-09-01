using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Typeof_struct03_struct03_
    {
        [OuterLoop]
        [Fact]
        public void _Typeof_struct03_struct03_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Typeof\\struct03\\struct03.cmd");
        }
    }
}
