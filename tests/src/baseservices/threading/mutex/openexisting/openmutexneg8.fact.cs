using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_openexisting_openmutexneg8_openmutexneg8_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg8_openmutexneg8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg8\\openmutexneg8.cmd");
        }
    }
}
