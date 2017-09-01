using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Arrays_ConstructedTypes_MultiDim_struct01_static_struct01_static_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_ConstructedTypes_MultiDim_struct01_static_struct01_static_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Arrays\\ConstructedTypes\\MultiDim\\struct01_static\\struct01_static.cmd");
        }
    }
}
