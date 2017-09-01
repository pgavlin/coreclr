using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Locals_instance_passing_class01_instance_passing_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Locals_instance_passing_class01_instance_passing_class01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Locals\\instance_passing_class01\\instance_passing_class01.cmd");
        }
    }
}
