using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_openexisting_openmutexneg6_openmutexneg6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_openexisting_openmutexneg6_openmutexneg6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\openexisting\\openmutexneg6\\openmutexneg6.cmd");
        }
    }
}
