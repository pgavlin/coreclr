using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    public class _Parameters_instance_passing_class01_instance_passing_class01_
    {
        [OuterLoop]
        [Fact]
        public void _Parameters_instance_passing_class01_instance_passing_class01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Generics\\Parameters\\instance_passing_class01\\instance_passing_class01.cmd");
        }
    }
}
